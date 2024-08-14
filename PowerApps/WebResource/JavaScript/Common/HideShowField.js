/**
 * Toggles the visibility of a form field in Power Apps based on a condition.
 *
 * @param {object} executionContext - The execution context provided by the form.
 * @param {string} fieldName - The logical name of the field to hide or show.
 * @param {boolean} isVisible - A boolean indicating whether the field should be visible.
 */
function toggleFieldVisibility(executionContext, fieldName, isVisible) {
    var formContext = executionContext.getFormContext();

    if (!formContext.getControl(fieldName)) {
        console.warn(`Field with logical name '${fieldName}' not found.`);
        return;
    }

    formContext.getControl(fieldName).setVisible(isVisible);
}


/**
 * following is the usecase of above function 
 * function onLoad(executionContext) {
    var formContext = executionContext.getFormContext();
    var someCondition = formContext.getAttribute("new_somefield").getValue() === "someValue";

    toggleFieldVisibility(executionContext, "new_examplefield", someCondition);
}
*/